/*
 * File:   TestRover.h
 * Author: Simonor
 *
 * Created on 14/10/2015, 1:53:22 PM
 */

#ifndef TESTROVER_H
#define	TESTROVER_H

#include <cppunit/extensions/HelperMacros.h>

class TestRover : public CPPUNIT_NS::TestFixture {
    CPPUNIT_TEST_SUITE(TestRover);

    CPPUNIT_TEST(testAttach);
    CPPUNIT_TEST(testFailAttach);
    
    CPPUNIT_TEST(testHighCharge);
    CPPUNIT_TEST(testDeattach);
    CPPUNIT_TEST(testAttachBattery);
    CPPUNIT_TEST(testDeatachBattery);
    
    CPPUNIT_TEST(testMemoryLeaks);
    CPPUNIT_TEST(testCopyConstructor);
    CPPUNIT_TEST(testObjectAliasing);
    CPPUNIT_TEST(testDrillSafetyCopy);
    CPPUNIT_TEST(testBatteryCopy);
    
    CPPUNIT_TEST_SUITE_END();

public:
    TestRover();
    virtual ~TestRover();
    void setUp();
    void tearDown();

private:
    void testAttach();
    void testFailAttach();    
    void testHighCharge();
    void testDeattach();
    void testAttachBattery();
    void testDeatachBattery();
    
    void testMemoryLeaks();
    void testCopyConstructor();
    void testObjectAliasing();
    void testDrillSafetyCopy();
    void testBatteryCopy();
};

#endif	/* TESTROVER_H */

