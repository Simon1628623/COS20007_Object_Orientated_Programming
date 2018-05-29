/* 
 * File:   Device.h
 * Author: Simonor
 *
 * Created on 15 October 2015, 1:38 PM
 */

#ifndef DEVICE_H
#define	DEVICE_H
#include "Battery.h"
#include "Object.h"

class Device: public Object {
public:
    Device();
    Device(const Device& orig);
    
    virtual Device* Clone() const = 0;
    
    virtual ~Device();
//    add a battery to the device
    void Connect(Battery* b);
//    disconnect the battery from the device
    void Disconnect();
//    virtual void for the derived classes for operating the device
    virtual void Operate();
protected:
//    devices have a battery attached
    Battery* _battery;
};

#endif	/* DEVICE_H */

