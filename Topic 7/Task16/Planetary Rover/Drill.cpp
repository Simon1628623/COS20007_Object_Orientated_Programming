/* 
 * File:   Drill.cpp
 * Author: Simonor
 * 
 * Created on 15 October 2015, 5:12 PM
 */

#include "Drill.h"
#include <iostream>
using namespace std;

Drill::Drill(bool safe) {
    _safetyEnabled = safe;
}

Drill::Drill(const Drill& orig) {
    _safetyEnabled = orig._safetyEnabled;
}

Drill* Drill::Clone() const
{
    return new Drill (*this);
}

Drill::~Drill() {
}

void Drill::Operate()
{
    if(_battery->Charge() >= 10)
    {  
        if(_safetyEnabled)
        {
            cout << "Safety First" << endl;
        }
        else
        {
            this->Drain(_battery);
            cout << "VRMM! VRMM!" << endl;
        }
    }
    else
        cout << "Not enough battery" << endl;
}

void Drill::Drain(Battery* b)
{
    b->setCharge(-10);
}

bool Drill::getSafety()
{
    return _safetyEnabled;
}

