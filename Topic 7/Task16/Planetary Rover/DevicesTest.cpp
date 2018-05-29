/*
 * File:   DevicesTest.cpp
 * Author: Simonor
 *
 * Created on 15/10/2015, 4:13:32 PM
 */

#include "DevicesTest.h"
#include "Sonar.h"
#include "Radar.h"
#include "Drill.h"


CPPUNIT_TEST_SUITE_REGISTRATION(DevicesTest);

DevicesTest::DevicesTest() {
}

DevicesTest::~DevicesTest() {
}

void DevicesTest::setUp() {
}

void DevicesTest::tearDown() {
}

void DevicesTest::testSonar() {
    Sonar* s = new Sonar();
    Battery* b = new Battery(50);
    s->Connect(b);
    s->Operate();
    
    std::cout << b->Charge() << std::endl;
    
    CPPUNIT_ASSERT(b->Charge() == 51);
    delete s, b;
}

void DevicesTest::testRadar() {
    Radar* s = new Radar();
    Battery* b = new Battery(50);
    s->Connect(b);
    s->Operate();
    
    CPPUNIT_ASSERT(b->Charge() == 46);
    delete s, b;
}

void DevicesTest::testDrill() {
    Drill* s = new Drill(false);
    Battery* b = new Battery(50);
    s->Connect(b);
    s->Operate();
    
    CPPUNIT_ASSERT(b->Charge() == 40);
    delete s, b;
}

void DevicesTest::testSafetyDrill() {
    Drill* s = new Drill(true);
    Battery* b = new Battery(50);
    s->Connect(b);
    s->Operate();
    
    CPPUNIT_ASSERT(b->Charge() == 50);
    delete s, b;
}

