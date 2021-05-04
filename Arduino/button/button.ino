#include "Button2.h";

Button2 buttonA = Button2(32);
Button2 buttonB = Button2(33);
Button2 buttonC = Button2(25);
Button2 buttonD = Button2(26);

void setup(){
    Serial.begin(115200);

    // Clear Boot up messy code
    Serial.println("");

    // Send key for Application
    Serial.println("MANE_TAIKO_DEMO");

    buttonA.setDebounceTime(50);
    buttonB.setDebounceTime(50);
    buttonC.setDebounceTime(50);
    buttonD.setDebounceTime(50);

    buttonA.setTapHandler(click);
    buttonB.setTapHandler(click);
    buttonC.setTapHandler(click);
    buttonD.setTapHandler(click);
}

void loop(){
    buttonA.loop();
    buttonB.loop();
    buttonC.loop();
    buttonD.loop();
}

void click(Button2& btn) {
    if (btn == buttonA) {
      Serial.println("M");
    } else if (btn == buttonB) {
      Serial.println("A");
    }else if (btn == buttonC) {
      Serial.println("N");
    }else if (btn == buttonD) {
      Serial.println("E");
    }
}