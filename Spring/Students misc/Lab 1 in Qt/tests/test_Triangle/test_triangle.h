#ifndef TEST_TRIANGLE_H
#define TEST_TRIANGLE_H

#include "../../Triangle/triangle.h"
#include <QObject>
#include <QTest>
#include <limits>
#include <cmath>

class Test_Triangle : public QObject
{
    Q_OBJECT
private slots:
    void setSides();
    void area();
};

#endif
