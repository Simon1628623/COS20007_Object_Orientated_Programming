/* 
 * File:   Battery.h
 * Author: Simonor
 *
 * Created on 15 October 2015, 2:40 PM
 */

#ifndef BATTERY_H
#define	BATTERY_H
#include "Object.h"

class Battery: public Object {
public:
//    constructor
    Battery(int charge);
    Battery(const Battery& orig);
    virtual ~Battery();
//    checks how much charge the battery has
    int Charge() const;
//    change the amount of charge the battery has
    void setCharge(int c);
private:
    signed int _charge;
};

#endif	/* BATTERY_H */

