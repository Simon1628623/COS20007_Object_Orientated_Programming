/*
 * File:   TestRover.cpp
 * Author: Simonor
 *
 * Created on 14/10/2015, 1:53:22 PM
 */

#include "TestRover.h"
#include "Rover.h"
#include "Radar.h"
#include "Device.h"
#include "Battery.h"
#include "Drill.h"
#include "Object.h"

CPPUNIT_TEST_SUITE_REGISTRATION(TestRover);

TestRover::TestRover() {
}

TestRover::~TestRover() {
}

void TestRover::setUp() {
}

void TestRover::tearDown() {
}

void TestRover::testAttach() {
    Rover* rover = new Rover();
    rover->attachDevice(new Radar());
    
    CPPUNIT_ASSERT(rover->deviceCount() == 1);
    delete rover;
}

void TestRover::testFailAttach() {
    Rover* rover = new Rover();
    rover->attachDevice(new Radar());
    rover->attachDevice(new Radar());
    
    CPPUNIT_ASSERT(rover->deviceCount() == 2);
    delete rover;
}

void TestRover::testHighCharge()
{
    Rover* rover = new Rover();
    Battery* b = new Battery(10);
    Battery* c = new Battery(4);
    
    rover->attachBattery(b);
    rover->attachBattery(c);
    
    Drill* d = new Drill(false);
    Radar* r = new Radar();
    
    rover->attachDevice(d);
    rover->Operate();
    rover->attachDevice(r);
    
    CPPUNIT_ASSERT(b->Charge() == 0);
    delete rover, b, c, r, d; 
}

void TestRover::testDeattach()
{
    Rover* rover = new Rover();
    Battery* b = new Battery(10);
    Battery* c = new Battery(4);
    
    rover->attachBattery(b);
    rover->attachBattery(c);
    
    Drill* d = new Drill(false);
    Radar* r = new Radar();
    
    rover->attachDevice(d);
    rover->Operate();
    rover->attachDevice(r);
    rover->detachDevice(d);
    
    CPPUNIT_ASSERT(rover->deviceCount() == 1);
    delete rover, b, c, r, d; 
}

void TestRover::testAttachBattery()
{
    Rover* rover = new Rover();
    Battery* b = new Battery(10);
    Battery* c = new Battery(4);
    
    rover->attachBattery(b);
    rover->attachBattery(c);
    
   
    
    CPPUNIT_ASSERT(rover->BatteryCount() == 2);
    delete rover, b, c; 
}

void TestRover::testDeatachBattery()
{
    Rover* rover = new Rover();
    Battery* b = new Battery(10);
    Battery* c = new Battery(4);
    
    rover->attachBattery(b);
    rover->attachBattery(c);
    rover->deatachBattery(b);
    
      
    CPPUNIT_ASSERT(rover->BatteryCount() == 1);
    delete rover, b, c; 
}

void TestRover::testMemoryLeaks()
{
    Rover* r = new Rover();
    r->attachDevice(new Radar());
    
    delete r;
    
    CPPUNIT_ASSERT(Object::getCount() == 0);
}

void TestRover::testCopyConstructor()
{
    Rover* r = new Rover();
    r->attachDevice(new Radar());
    Rover* copy = new Rover(*r);
    
    CPPUNIT_ASSERT(r->deviceCount() == copy->deviceCount());
}

void TestRover::testObjectAliasing()
{
    Rover* r = new Rover();
    r->attachDevice(new Radar());
    
    Rover* copy = new Rover(*r);
    
    delete r;
    
    //if this test fails, then the following line causes a crash
    delete copy;
    
    //if the program is still running, then the test has passed
    CPPUNIT_ASSERT(true);
}

void TestRover::testDrillSafetyCopy()
{
    Drill* r = new Drill(true);
    
    
    Drill* copy = r->Clone();
    
    
    //if the program is still running, then the test has passed
    CPPUNIT_ASSERT(copy->getSafety() == r->getSafety());
    
    delete r, copy;
}

void TestRover::testBatteryCopy()
{
    Battery* b = new Battery(50);
    Battery* copy = new Battery(*b);
    
    CPPUNIT_ASSERT(copy->Charge() == b->Charge());
}

