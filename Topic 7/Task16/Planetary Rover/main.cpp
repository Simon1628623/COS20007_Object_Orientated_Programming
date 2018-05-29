/* 
 * File:   main.cpp
 * Author: Simonor
 *
 * Created on 14 October 2015, 1:34 PM
 */

#include <cstdlib>
#include <iostream>
#include "Battery.h"
#include "Object.h"
#include "Drill.h"
#include "Radar.h"
#include "Rover.h"
#include "Sonar.h"



using namespace std;

bool testMemoryLeaks();
bool testCopyConstructor();
bool testDanglingReference();
bool testObjectAliasing();
bool testDrillSafetyCopy();
bool testBatteryCopy();

int main(int argc, char** argv) {
    int test = 0;
    
    cout << "-before memory leak test no: 1" << endl;
    if(testMemoryLeaks())
    {
        test += 1;
    }
    cout << "-before copy constructor test no: 2" << endl;
    if(testCopyConstructor())
    {
        test += 1;
    }
      cout << "-before dandling reference test no: 3" << endl;
    if(testDanglingReference())
    {
        test += 1;
    }
    cout << "-before aliasing test no: 4" << endl;
    if(testObjectAliasing())
        test += 1;
    cout << "-before drill test no: 5" << endl;
    if(testDrillSafetyCopy())
    {
        test += 1;
    }
    cout << "-before battery copy test no: 6" << endl;
            
    if(testBatteryCopy())
    {
        test += 1;
    }
    
    cout << "///TEST RESULTS: " << test << "/6 passed" << endl;
    
    return 0;
}


bool testMemoryLeaks()
{
    Rover* r = new Rover();
       
    r->attachBattery(new Battery(50));
    r->attachBattery(new Battery(150));
    r->attachDevice(new Radar());
    
    delete r;
    
    if(Object::getCount() == 0)
    {
        cout << "///memory has no leaks" << endl;
        return true;
    }
    else
    {
        cout << "///memory leaking" << endl;
        return false;
    }
}

bool testCopyConstructor()
{
    Rover* r2 = new Rover();
    
    r2->attachBattery(new Battery(50));
    r2->attachBattery(new Battery(150));
    
    r2->attachDevice(new Radar());
    Rover* copy = new Rover(*r2);
    
    if(r2->deviceCount() == copy->deviceCount())
    {
        cout << "///copy has devices original had" << endl;
        return true;
    }
    else
    {
        cout << "///copy lost devices " << r2->deviceCount() << "orig-copy" << copy->deviceCount()<< endl;
        return false;
    }
    delete r2, copy;
}

bool testDanglingReference()
{
    Rover* r2 = new Rover();
    
    r2->attachBattery(new Battery(50));
    r2->attachBattery(new Battery(150));
    
    r2->attachDevice(new Radar());
    Rover* copy = new Rover(*r2);
    delete r2;
    copy->attachDevice(new Sonar());
    
    if(copy->deviceCount() == 2)
    {
        cout << "///copy has 2 devices and original is deleted" << endl;
        return true;
    }
    else
    {
        cout << "///copy broke " << "copy device count: " << copy->deviceCount()<< endl;
        return false;
    }
    delete copy;
}

bool testObjectAliasing()
{
    Rover* r3 = new Rover();
    r3->attachBattery(new Battery(50));
    r3->attachDevice(new Radar());
    
    Rover* copy2 = new Rover(*r3);
    
    delete r3;
    
    //if this test fails, then the following line causes a crash
    delete copy2;
    
    //if the program is still running, then the test has passed
    if(true)
    {
        cout << "///objectAliasing didn't crash program" << endl;
        return true;
    }
}

bool testDrillSafetyCopy()
{
    Drill* d = new Drill(true);
    
    
    Drill* dcopy = d->Clone();
    
    
    //if the program is still running, then the test has passed
    if(dcopy->getSafety() == d->getSafety())
    {
        cout << "///copied the drills safety" << endl;
        return true;
    }
    else 
    {
        cout << "///drill did not keep safety" << endl;
        return false;
    }
    delete d, dcopy;
}

bool testBatteryCopy()
{
    Battery* b = new Battery(50);
    Battery* bcopy = new Battery(*b);
    delete b;
    bcopy->setCharge(5);
    if(bcopy->Charge() == 55)
    {
        cout << "///battery copy has same charge" << endl;
        return true;
    }
    else
    {
        cout << "///battery changed charge" << endl;
        return false;
    }
    delete bcopy;
}