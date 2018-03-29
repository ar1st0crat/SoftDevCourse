QT       += testlib

QT       -= gui

TARGET = test_triangle
CONFIG   += console
CONFIG   -= app_bundle

TEMPLATE = app

SOURCES += \
        test_triangle.cpp \ 
    ../../Triangle/triangle.cpp

DEFINES += SRCDIR=\\\"$$PWD/\\\"

HEADERS += \
    test_triangle.h \
    ../../Triangle/my_exceptions.h \
    ../../Triangle/triangle.h
