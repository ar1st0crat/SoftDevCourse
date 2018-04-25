QT       += testlib
QT       -= gui
TARGET = test_arrayprocessor
CONFIG   += console
CONFIG   -= app_bundle
TEMPLATE = app

SOURCES += \
    ../../ArrayProcessor/arrayprocessor.cpp \
    test_arrayprocessor.cpp

DEFINES += SRCDIR=\\\"$$PWD/\\\"

HEADERS += \
    ../../ArrayProcessor/arrayprocessor.h \
    test_arrayprocessor.h

