/* 
 * File:   Radar.h
 * Author: Simonor
 *
 * Created on 14 October 2015, 1:58 PM
 */

#ifndef RADAR_H
#define	RADAR_H
#include "Device.h"
#include "Battery.h"

class Radar: public Device {
public:
    Radar();
    Radar(const Radar& orig);
    
    virtual Radar* Clone () const;
    
    virtual ~Radar();
/// Calls Activat and Drain    
    void Operate();
/// Randomises result Ping or Pong
    void Activate();
/// Drains battery by 4 units
    void Drain(Battery* b);
private:

};

#endif	/* RADAR_H */

