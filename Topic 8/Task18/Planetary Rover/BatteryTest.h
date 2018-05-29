/*
 * File:   BatteryTest.h
 * Author: Simonor
 *
 * Created on 15/10/2015, 3:01:50 PM
 */

#ifndef BATTERYTEST_H
#define	BATTERYTEST_H

#include <cppunit/extensions/HelperMacros.h>

class BatteryTest : public CPPUNIT_NS::TestFixture {
    CPPUNIT_TEST_SUITE(BatteryTest);

    CPPUNIT_TEST(testCharge);
    CPPUNIT_TEST(testDrain);
    CPPUNIT_TEST(testGet);

    CPPUNIT_TEST_SUITE_END();

public:
    BatteryTest();
    virtual ~BatteryTest();
    void setUp();
    void tearDown();

private:
    void testCharge();
    void testDrain();
    void testGet();
};

#endif	/* BATTERYTEST_H */

