/* 
 * File:   Rover.cpp
 * Author: Simonor
 * 
 * Created on 14 October 2015, 1:58 PM
 */

#include "Rover.h"
#include "Device.h"
#include "Battery.h"
#include <vector>
#include <iostream>
using namespace std;

Rover::Rover() {
}

Rover::Rover(const Rover& orig) {
    vector<Battery*> batt = orig._batteries;
    
    _batteries.resize(orig._batteries.size());
    
    for (int i = 0; i < _batteries.size(); i++)
    { 
        _batteries[i]=batt[i];
    }
    
    vector<Device*> dev = orig._devices;
    
    _devices.resize(orig.deviceCount());
    
    for (int i = 0; i < _devices.size(); i++)
    {  
       _devices[i] = dev[i]->Clone();
    }

    
}

Rover::~Rover() {
    cout << "before deleting devices" << endl;
    for(int i=0; i<deviceCount(); i++)
    {
        delete _devices[i];  
    }
    cout << "before deleting batteries" << endl;
    for(int i=0; i<BatteryCount(); i++)
    {
        delete _batteries[i];
    }
    cout << "before deleting self" << endl;
    //delete this;
}

int Rover::deviceCount() const
{
    return _devices.size();
}

int Rover::BatteryCount() const
{
    return _batteries.size();
}

void Rover::attachDevice(Device* d)
{
    cout << "before connect" << endl;
    if(_batteries[0] != 0)
        d->Connect(HighCharged());
    cout << "adding device to vector" << endl;
            
    _devices.push_back(d);
}

void Rover::detachDevice(Device* d)
{
    for(int i=0; i<_devices.size(); i++)
    {
        if(_devices[i] == d)
        {
            _devices.erase(_devices.end()-i);
        }
    }
}

void Rover::Operate()
{
    for(int i=0; i<_devices.size(); i++)
    {
        _devices[i]->Operate();
    }
}

Battery* Rover::HighCharged()
{
    cout << "start of highcharged" << endl;
    if(_batteries[0] != 0)
    {
        Battery* b = _batteries[0];
        for(int i=1; i<_batteries.size(); i++)
        {
            if(_batteries[i]->Charge() > b->Charge())
            {
                b = _batteries[i];
                cout << "found bigger charged battery" << endl;
            }
        }
        cout << "before returning value" << endl;
        return b;
    }
    else
    {
        cout << "no batteries listed" << endl;
        return 0;
    }
    
}

void Rover::attachBattery(Battery* b)
{
    if(b->Charge() >= 0)
    {
        _batteries.push_back(b);
    }
}

void Rover::deatachBattery(Battery* b)
{
    for(int i=0; i<_batteries.size(); i++)
    {
        if(_batteries[i] == b)
        {
            _batteries.erase(_batteries.end()-i);
        }
    }
}
