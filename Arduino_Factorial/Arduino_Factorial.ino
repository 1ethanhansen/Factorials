// initialize variables
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
  
  // obtain the number to factorialize from the arduino
  factorial = Serial.read()-'0';
  
  // set the counter equal to the numer to factorialize (dictates how many multiplication operations will occur)
  counter = factorial;
  
  // carry out the factorialization using a while loop until counter is equal to 1
  if (factorial > 0) {
    while (counter > 1) {
      total *= counter;
      counter--;
    }
    
    // shows the factorialization of the input number on the arduino
    Serial.print(factorial);
    Serial.print("! = ");
    Serial.println(total);
  }
}
