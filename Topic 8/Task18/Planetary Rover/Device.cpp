/* 
 * File:   Device.cpp
 * Author: Simonor
 * 
 * Created on 15 October 2015, 1:38 PM
 */

#include "Device.h"


Device::Device() {
}

Device::Device(const Device& orig) {
}

Device::~Device() {
    //delete _battery;
    //delete this;
}

void Device::Connect(Battery* b)
{
    _battery = b;
}

void Device::Disconnect()
{
    _battery = 0;
}

void Device::Operate()
{
    
}
    
