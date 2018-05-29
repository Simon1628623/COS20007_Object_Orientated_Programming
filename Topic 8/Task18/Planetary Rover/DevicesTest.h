/*
 * File:   DevicesTest.h
 * Author: Simonor
 *
 * Created on 15/10/2015, 4:13:32 PM
 */

#ifndef DEVICESTEST_H
#define	DEVICESTEST_H

#include <cppunit/extensions/HelperMacros.h>

class DevicesTest : public CPPUNIT_NS::TestFixture {
    CPPUNIT_TEST_SUITE(DevicesTest);

    CPPUNIT_TEST(testSonar);
    CPPUNIT_TEST(testRadar);
    CPPUNIT_TEST(testDrill);
    CPPUNIT_TEST(testSafetyDrill);

    CPPUNIT_TEST_SUITE_END();

public:
    DevicesTest();
    virtual ~DevicesTest();
    void setUp();
    void tearDown();

private:
    void testSonar();
    void testRadar();
    void testDrill();
    void testSafetyDrill();
    
};

#endif	/* DEVICESTEST_H */

