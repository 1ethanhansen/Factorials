int factorial;
int counter;
double total = 1;

void setup() {
  // put your setup code here, to run once:
    Serial.begin(9600);
    Serial.println("Enter the number to factorialize");
}

void loop() {
  // put your main code here, to run repeatedly:
  factorial = Serial.read()-'0';
  counter = factorial;
  if (factorial > 0) {
    while (counter > 1) {
      total *= counter;
      counter--;
    }
    Serial.print(factorial);
    Serial.print("! = ");
    Serial.println(total);
  }
}
