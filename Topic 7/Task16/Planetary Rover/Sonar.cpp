/* 
 * File:   Sonar.cpp
 * Author: Simonor
 * 
 * Created on 15 October 2015, 4:14 PM
 */

#include "Sonar.h"
#include <iostream>
using namespace std;

Sonar::Sonar() {
}

Sonar::Sonar(const Sonar& orig) {
}

Sonar* Sonar::Clone() const
{
    return new Sonar(*this);
}

Sonar::~Sonar() {
}

void Sonar::Operate()
{
    this->Charge();
    cout << "Charging" << endl;
}

void Sonar::Charge()
{
    _battery->setCharge(1);
}
