/*
 * File:   BatteryTest.cpp
 * Author: Simonor
 *
 * Created on 15/10/2015, 3:01:50 PM
 */

#include "BatteryTest.h"
#include "Battery.h"


CPPUNIT_TEST_SUITE_REGISTRATION(BatteryTest);

BatteryTest::BatteryTest() {
}

BatteryTest::~BatteryTest() {
}

void BatteryTest::setUp() {
}

void BatteryTest::tearDown() {
}

void BatteryTest::testCharge() {
    Battery* b = new Battery(50);
    b->setCharge(5); 
    CPPUNIT_ASSERT(b->Charge() == 55);
    delete b;
}

void BatteryTest::testDrain() {
    Battery* b = new Battery(50);
    b->setCharge(-5);
    CPPUNIT_ASSERT(b->Charge() == 45);
    delete b;
}

void BatteryTest::testGet(){
    Battery* b = new Battery(50);
        
    CPPUNIT_ASSERT(b->Charge() == 50);
    delete b;
}

