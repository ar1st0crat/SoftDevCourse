#ifndef TEST_STRINGFORMATTER_H
#define TEST_STRINGFORMATTER_H

#include "../../StringFormatter/stringformatter.h"
#include <QObject>
#include <QTest>


class Test_StringFormatter : public QObject
{
    Q_OBJECT
private slots:
    void webString();
};

#endif
