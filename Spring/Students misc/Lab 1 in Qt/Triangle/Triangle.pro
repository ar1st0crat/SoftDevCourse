QT -= gui

CONFIG += c++11 console
CONFIG -= app_bundle

DEFINES += QT_DISABLE_DEPRECATED_BEFORE=0x060000    # disables all the APIs deprecated before Qt 6.0.0

SOURCES += main.cpp \
    triangle.cpp

HEADERS += \
    triangle.h \
    my_exceptions.h
