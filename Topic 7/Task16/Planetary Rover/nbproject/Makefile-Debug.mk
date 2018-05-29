#
# Generated Makefile - do not edit!
#
# Edit the Makefile in the project folder instead (../Makefile). Each target
# has a -pre and a -post target defined where you can add customized code.
#
# This makefile implements configuration specific macros and targets.


# Environment
MKDIR=mkdir
CP=cp
GREP=grep
NM=nm
CCADMIN=CCadmin
RANLIB=ranlib
CC=gcc
CCC=g++
CXX=g++
FC=gfortran
AS=as

# Macros
CND_PLATFORM=MinGW-Windows
CND_DLIB_EXT=dll
CND_CONF=Debug
CND_DISTDIR=dist
CND_BUILDDIR=build

# Include project Makefile
include Makefile

# Object Directory
OBJECTDIR=${CND_BUILDDIR}/${CND_CONF}/${CND_PLATFORM}

# Object Files
OBJECTFILES= \
	${OBJECTDIR}/Battery.o \
	${OBJECTDIR}/Device.o \
	${OBJECTDIR}/Drill.o \
	${OBJECTDIR}/Object.o \
	${OBJECTDIR}/Radar.o \
	${OBJECTDIR}/Rover.o \
	${OBJECTDIR}/Sonar.o \
	${OBJECTDIR}/main.o

# Test Directory
TESTDIR=${CND_BUILDDIR}/${CND_CONF}/${CND_PLATFORM}/tests

# Test Files
TESTFILES= \
	${TESTDIR}/TestFiles/f1 \
	${TESTDIR}/TestFiles/f3 \
	${TESTDIR}/TestFiles/f2

# C Compiler Flags
CFLAGS=

# CC Compiler Flags
CCFLAGS=
CXXFLAGS=

# Fortran Compiler Flags
FFLAGS=

# Assembler Flags
ASFLAGS=

# Link Libraries and Options
LDLIBSOPTIONS=

# Build Targets
.build-conf: ${BUILD_SUBPROJECTS}
	"${MAKE}"  -f nbproject/Makefile-${CND_CONF}.mk ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/planetary_rover.exe

${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/planetary_rover.exe: ${OBJECTFILES}
	${MKDIR} -p ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}
	${LINK.cc} -o ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/planetary_rover ${OBJECTFILES} ${LDLIBSOPTIONS}

${OBJECTDIR}/Battery.o: Battery.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.cc) -g -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/Battery.o Battery.cpp

${OBJECTDIR}/Device.o: Device.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.cc) -g -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/Device.o Device.cpp

${OBJECTDIR}/Drill.o: Drill.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.cc) -g -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/Drill.o Drill.cpp

${OBJECTDIR}/Object.o: Object.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.cc) -g -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/Object.o Object.cpp

${OBJECTDIR}/Radar.o: Radar.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.cc) -g -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/Radar.o Radar.cpp

${OBJECTDIR}/Rover.o: Rover.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.cc) -g -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/Rover.o Rover.cpp

${OBJECTDIR}/Sonar.o: Sonar.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.cc) -g -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/Sonar.o Sonar.cpp

${OBJECTDIR}/main.o: main.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.cc) -g -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/main.o main.cpp

# Subprojects
.build-subprojects:

# Build Test Targets
.build-tests-conf: .build-conf ${TESTFILES}
${TESTDIR}/TestFiles/f1: ${TESTDIR}/TestRover.o ${TESTDIR}/test_rover.o ${OBJECTFILES:%.o=%_nomain.o}
	${MKDIR} -p ${TESTDIR}/TestFiles
	${LINK.cc}   -o ${TESTDIR}/TestFiles/f1 $^ ${LDLIBSOPTIONS} `cppunit-config --libs` `cppunit-config --libs` `cppunit-config --libs`   

${TESTDIR}/TestFiles/f3: ${TESTDIR}/BatteryTest.o ${TESTDIR}/battery_test.o ${OBJECTFILES:%.o=%_nomain.o}
	${MKDIR} -p ${TESTDIR}/TestFiles
	${LINK.cc}   -o ${TESTDIR}/TestFiles/f3 $^ ${LDLIBSOPTIONS} `cppunit-config --libs`   

${TESTDIR}/TestFiles/f2: ${TESTDIR}/DevicesTest.o ${TESTDIR}/devices_test.o ${OBJECTFILES:%.o=%_nomain.o}
	${MKDIR} -p ${TESTDIR}/TestFiles
	${LINK.cc}   -o ${TESTDIR}/TestFiles/f2 $^ ${LDLIBSOPTIONS} `cppunit-config --libs` `cppunit-config --libs`   


${TESTDIR}/TestRover.o: TestRover.cpp 
	${MKDIR} -p ${TESTDIR}
	${RM} "$@.d"
	$(COMPILE.cc) -g `cppunit-config --cflags` -MMD -MP -MF "$@.d" -o ${TESTDIR}/TestRover.o TestRover.cpp


${TESTDIR}/test_rover.o: test_rover.cpp 
	${MKDIR} -p ${TESTDIR}
	${RM} "$@.d"
	$(COMPILE.cc) -g `cppunit-config --cflags` -MMD -MP -MF "$@.d" -o ${TESTDIR}/test_rover.o test_rover.cpp


${TESTDIR}/BatteryTest.o: BatteryTest.cpp 
	${MKDIR} -p ${TESTDIR}
	${RM} "$@.d"
	$(COMPILE.cc) -g `cppunit-config --cflags` -MMD -MP -MF "$@.d" -o ${TESTDIR}/BatteryTest.o BatteryTest.cpp


${TESTDIR}/battery_test.o: battery_test.cpp 
	${MKDIR} -p ${TESTDIR}
	${RM} "$@.d"
	$(COMPILE.cc) -g `cppunit-config --cflags` -MMD -MP -MF "$@.d" -o ${TESTDIR}/battery_test.o battery_test.cpp


${TESTDIR}/DevicesTest.o: DevicesTest.cpp 
	${MKDIR} -p ${TESTDIR}
	${RM} "$@.d"
	$(COMPILE.cc) -g -I. `cppunit-config --cflags` -MMD -MP -MF "$@.d" -o ${TESTDIR}/DevicesTest.o DevicesTest.cpp


${TESTDIR}/devices_test.o: devices_test.cpp 
	${MKDIR} -p ${TESTDIR}
	${RM} "$@.d"
	$(COMPILE.cc) -g -I. `cppunit-config --cflags` -MMD -MP -MF "$@.d" -o ${TESTDIR}/devices_test.o devices_test.cpp


${OBJECTDIR}/Battery_nomain.o: ${OBJECTDIR}/Battery.o Battery.cpp 
	${MKDIR} -p ${OBJECTDIR}
	@NMOUTPUT=`${NM} ${OBJECTDIR}/Battery.o`; \
	if (echo "$$NMOUTPUT" | ${GREP} '|main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T _main$$'); \
	then  \
	    ${RM} "$@.d";\
	    $(COMPILE.cc) -g -Dmain=__nomain -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/Battery_nomain.o Battery.cpp;\
	else  \
	    ${CP} ${OBJECTDIR}/Battery.o ${OBJECTDIR}/Battery_nomain.o;\
	fi

${OBJECTDIR}/Device_nomain.o: ${OBJECTDIR}/Device.o Device.cpp 
	${MKDIR} -p ${OBJECTDIR}
	@NMOUTPUT=`${NM} ${OBJECTDIR}/Device.o`; \
	if (echo "$$NMOUTPUT" | ${GREP} '|main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T _main$$'); \
	then  \
	    ${RM} "$@.d";\
	    $(COMPILE.cc) -g -Dmain=__nomain -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/Device_nomain.o Device.cpp;\
	else  \
	    ${CP} ${OBJECTDIR}/Device.o ${OBJECTDIR}/Device_nomain.o;\
	fi

${OBJECTDIR}/Drill_nomain.o: ${OBJECTDIR}/Drill.o Drill.cpp 
	${MKDIR} -p ${OBJECTDIR}
	@NMOUTPUT=`${NM} ${OBJECTDIR}/Drill.o`; \
	if (echo "$$NMOUTPUT" | ${GREP} '|main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T _main$$'); \
	then  \
	    ${RM} "$@.d";\
	    $(COMPILE.cc) -g -Dmain=__nomain -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/Drill_nomain.o Drill.cpp;\
	else  \
	    ${CP} ${OBJECTDIR}/Drill.o ${OBJECTDIR}/Drill_nomain.o;\
	fi

${OBJECTDIR}/Object_nomain.o: ${OBJECTDIR}/Object.o Object.cpp 
	${MKDIR} -p ${OBJECTDIR}
	@NMOUTPUT=`${NM} ${OBJECTDIR}/Object.o`; \
	if (echo "$$NMOUTPUT" | ${GREP} '|main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T _main$$'); \
	then  \
	    ${RM} "$@.d";\
	    $(COMPILE.cc) -g -Dmain=__nomain -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/Object_nomain.o Object.cpp;\
	else  \
	    ${CP} ${OBJECTDIR}/Object.o ${OBJECTDIR}/Object_nomain.o;\
	fi

${OBJECTDIR}/Radar_nomain.o: ${OBJECTDIR}/Radar.o Radar.cpp 
	${MKDIR} -p ${OBJECTDIR}
	@NMOUTPUT=`${NM} ${OBJECTDIR}/Radar.o`; \
	if (echo "$$NMOUTPUT" | ${GREP} '|main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T _main$$'); \
	then  \
	    ${RM} "$@.d";\
	    $(COMPILE.cc) -g -Dmain=__nomain -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/Radar_nomain.o Radar.cpp;\
	else  \
	    ${CP} ${OBJECTDIR}/Radar.o ${OBJECTDIR}/Radar_nomain.o;\
	fi

${OBJECTDIR}/Rover_nomain.o: ${OBJECTDIR}/Rover.o Rover.cpp 
	${MKDIR} -p ${OBJECTDIR}
	@NMOUTPUT=`${NM} ${OBJECTDIR}/Rover.o`; \
	if (echo "$$NMOUTPUT" | ${GREP} '|main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T _main$$'); \
	then  \
	    ${RM} "$@.d";\
	    $(COMPILE.cc) -g -Dmain=__nomain -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/Rover_nomain.o Rover.cpp;\
	else  \
	    ${CP} ${OBJECTDIR}/Rover.o ${OBJECTDIR}/Rover_nomain.o;\
	fi

${OBJECTDIR}/Sonar_nomain.o: ${OBJECTDIR}/Sonar.o Sonar.cpp 
	${MKDIR} -p ${OBJECTDIR}
	@NMOUTPUT=`${NM} ${OBJECTDIR}/Sonar.o`; \
	if (echo "$$NMOUTPUT" | ${GREP} '|main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T _main$$'); \
	then  \
	    ${RM} "$@.d";\
	    $(COMPILE.cc) -g -Dmain=__nomain -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/Sonar_nomain.o Sonar.cpp;\
	else  \
	    ${CP} ${OBJECTDIR}/Sonar.o ${OBJECTDIR}/Sonar_nomain.o;\
	fi

${OBJECTDIR}/main_nomain.o: ${OBJECTDIR}/main.o main.cpp 
	${MKDIR} -p ${OBJECTDIR}
	@NMOUTPUT=`${NM} ${OBJECTDIR}/main.o`; \
	if (echo "$$NMOUTPUT" | ${GREP} '|main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T main$$') || \
	   (echo "$$NMOUTPUT" | ${GREP} 'T _main$$'); \
	then  \
	    ${RM} "$@.d";\
	    $(COMPILE.cc) -g -Dmain=__nomain -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/main_nomain.o main.cpp;\
	else  \
	    ${CP} ${OBJECTDIR}/main.o ${OBJECTDIR}/main_nomain.o;\
	fi

# Run Test Targets
.test-conf:
	@if [ "${TEST}" = "" ]; \
	then  \
	    ${TESTDIR}/TestFiles/f1 || true; \
	    ${TESTDIR}/TestFiles/f3 || true; \
	    ${TESTDIR}/TestFiles/f2 || true; \
	else  \
	    ./${TEST} || true; \
	fi

# Clean Targets
.clean-conf: ${CLEAN_SUBPROJECTS}
	${RM} -r ${CND_BUILDDIR}/${CND_CONF}
	${RM} ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/planetary_rover.exe

# Subprojects
.clean-subprojects:

# Enable dependency checking
.dep.inc: .depcheck-impl

include .dep.inc
