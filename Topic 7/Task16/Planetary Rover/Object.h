/* 
 * File:   Object.h
 * Author: Simonor
 *
 * Created on 16 October 2015, 3:17 PM
 */

#ifndef OBJECT_H
#define	OBJECT_H

class Object {
public:
    Object();
    Object(const Object&);
    virtual ~Object();
    
//    return the count of current object instances
    static int getCount();
private:
//count of all object instances in existence
//    static - class wide field 
    static int _count;
    
};

#endif	/* OBJECT_H */

