/* 
 * File:   Drill.h
 * Author: Simonor
 *
 * Created on 15 October 2015, 5:12 PM
 */

#ifndef DRILL_H
#define	DRILL_H
#include "Device.h"
#include "Battery.h"

class Drill: public Device {
public:
    Drill(bool safe);
    Drill(const Drill& orig);
    
    virtual Drill* Clone() const;
    
    virtual ~Drill();
    
    bool getSafety();
    
//    if safety enabled "Safety first" displayed otherwise if safety is off will drain battery and display VRMM 
    void Operate();
//    draining battery
    void Drain(Battery* b);
    
private:
//    for checking to see if safety is enabled
    bool _safetyEnabled;

};

#endif	/* DRILL_H */

