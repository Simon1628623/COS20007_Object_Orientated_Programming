/* 
 * File:   Battery.cpp
 * Author: Simonor
 * 
 * Created on 15 October 2015, 2:40 PM
 */

#include "Battery.h"

Battery::Battery(int charge) 
{
    _charge = charge;
}

Battery::Battery(const Battery& orig) {
    _charge = orig._charge;
}

Battery::~Battery() {
}

int Battery::Charge() const
{
    return _charge;
}

void Battery::setCharge(int c)
{
    if(c > 0)
    {
        _charge += c;
    }
    else if(c < 0)
    {
        _charge -= -c;
    }
}

