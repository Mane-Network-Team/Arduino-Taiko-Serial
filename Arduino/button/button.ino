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

    buttonA.setDebounceTime(10);
    buttonB.setDebounceTime(10);
    buttonC.setDebounceTime(10);
    buttonD.setDebounceTime(10);

    buttonA.setPressedHandler(click);
    buttonB.setPressedHandler(click);
    buttonC.setPressedHandler(click);
    buttonD.setPressedHandler(click);
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