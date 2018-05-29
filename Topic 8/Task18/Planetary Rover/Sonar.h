/* 
 * File:   Sonar.h
 * Author: Simonor
 *
 * Created on 15 October 2015, 4:14 PM
 */

#ifndef SONAR_H
#define	SONAR_H
#include "Device.h"

class Sonar: public Device {
public:
    Sonar();
    Sonar(const Sonar& orig);
    
    virtual Sonar* Clone() const;
    
    virtual ~Sonar();
//    when operated adds 1 unit of power to battery and displays charging
    void Operate();
//    charges battery 1 unit
    void Charge();
private:

};

#endif	/* SONAR_H */

