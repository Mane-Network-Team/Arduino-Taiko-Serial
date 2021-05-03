void setup(){
    Serial.begin(115200);
	
	// Clear the messy code when boot up
    Serial.println("");
	
	// Send to the program say it work !
    Serial.println("MANE_TAIKO_DEMO");
}


void loop(){
    delay(100);
	
	// M = Button A
	// A = Button B
	// N = Button C
	// E = Button D
	
    char key[] = {'M','A','N','E'};
    Serial.println(key[random(4)]);
    Serial.flush();
}