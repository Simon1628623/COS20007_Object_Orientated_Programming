/* 
 * File:   Radar.cpp
 * Author: Simonor
 * 
 * Created on 14 October 2015, 1:58 PM
 */

#include "Radar.h"
#include <stdlib.h>
#include <string>
#include <iostream>

using namespace std;

Radar::Radar() {
}

Radar::Radar(const Radar& orig) {
}

Radar* Radar::Clone() const
{
    return new Radar(*this);
}

Radar::~Radar() {
}

void Radar::Operate()
{
    if(_battery->Charge() >= 4)
    {    
        this->Activate();
        this->Drain(_battery);
    }
    else
        cout << "Not enough battery" << endl;
}

void Radar::Activate()
{
    int i = rand() %4;
    if(i == 0)
    {
       cout << "PING" << endl; 
    }
    else
    {
        cout << "PONG" << endl;
    }
}

void Radar::Drain(Battery* b)
{
    b->setCharge(-4);
}