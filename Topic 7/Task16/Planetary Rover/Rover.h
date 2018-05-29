/* 
 * File:   Rover.h
 * Author: Simonor
 *
 * Created on 14 October 2015, 1:58 PM
 */

#ifndef ROVER_H
#define	ROVER_H
#include "Device.h"
#include "Battery.h"
#include "Object.h"
#include <vector>
#include <iostream>
using namespace std;

class Rover: public Object {
public:
    Rover();
    Rover(const Rover& orig);
    virtual ~Rover();
//attach a new device to the rover    
    void attachDevice(Device* d);
//remove a device from the rover    
    void detachDevice(Device* d);
//count the amount of devices    
    int deviceCount() const;
//    count amount of batteries
    int BatteryCount() const;
//attach a battery to the rover    
    void attachBattery(Battery* b);
//    deatach a battery from the rover
    void deatachBattery(Battery* b);
// operating all the devices attached to the rover   
    void Operate();
//    returns battery with highest charge
    Battery* HighCharged();
private:
//    all the devices connected to the rover
    vector <Device*> _devices;
//    all the batteries connected to the rover
    vector <Battery*> _batteries;

};

#endif	/* ROVER_H */

