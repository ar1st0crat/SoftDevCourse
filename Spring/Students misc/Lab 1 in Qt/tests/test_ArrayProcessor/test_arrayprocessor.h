#ifndef TEST_ARRAYPROCESSOR_H
#define TEST_ARRAYPROCESSOR_H

#include "../../ArrayProcessor/arrayprocessor.h"
#include <QObject>
#include <QVector>
#include <QTest>
#include <vector>

class Test_ArrayProcessor : public QObject
{
    Q_OBJECT
private slots:
    void sortAndFilter();
};

#endif
