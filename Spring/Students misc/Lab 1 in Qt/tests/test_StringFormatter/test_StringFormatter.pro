QT       += testlib

QT       -= gui

TARGET = test_stringformatter
CONFIG   += console
CONFIG   -= app_bundle

SOURCES += \
        test_stringformatter.cpp \ 
    ../../StringFormatter/stringformatter.cpp

DEFINES += SRCDIR=\\\"$$PWD/\\\"

HEADERS += \
    test_stringformatter.h \
    ../../StringFormatter/stringformatter.h

SUBDIRS += \
    ../../StringFormatter/StringFormatter.pro
