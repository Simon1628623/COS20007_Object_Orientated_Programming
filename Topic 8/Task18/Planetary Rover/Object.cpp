/* 
 * File:   Object.cpp
 * Author: Simonor
 * 
 * Created on 16 October 2015, 3:17 PM
 */

#include "Object.h"

int Object::_count = 0;

//read only access to instance count
int Object::getCount()
{
    return _count;
}

Object::Object() {
    _count++;
}

//for instances like Rover* B = new Rover (*A);
Object::Object(const Object&) {
    _count++;
}

Object::~Object() {
    _count--;
}

