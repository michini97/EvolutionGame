#include <CurieIMU.h>
#include <MahonyAHRS.h>

Mahony filter;

void setup() {
  Serial.begin(9600);
  CurieIMU.begin();
  calibrate();
}

void loop() {
  int ax, ay, az;
  int gx, gy, gz;
  float roll, pitch, heading;

  // Read the motion sensors
  CurieIMU.readMotionSensor(ax, ay, az, gx, gy, gz);

  // Update the Mahony filter, with scaled gyroscope
  float gyroScale = 0.001;  // TODO: the filter updates too fast
  filter.updateIMU(gx * gyroScale, gy * gyroScale, gz * gyroScale, ax, ay, az);


  if (Serial.available() > 0) {
    int val = Serial.read();
    if (val == 's') { // if incoming serial is "s"
      roll = filter.getRoll();
      pitch = filter.getPitch();
      heading = filter.getYaw();
      Serial.print(heading);
      Serial.print(",");
      Serial.print(pitch);
      Serial.print(",");
      Serial.println(roll);
    }
    if (val == 'c') {
      calibrate();
    }
  }
}

// calibrates gyroscope and accelerometer
void calibrate() {
  CurieIMU.autoCalibrateGyroOffset();
  CurieIMU.autoCalibrateAccelerometerOffset(X_AXIS, 0);
  CurieIMU.autoCalibrateAccelerometerOffset(Y_AXIS, 0);
  CurieIMU.autoCalibrateAccelerometerOffset(Z_AXIS, 1);
}

