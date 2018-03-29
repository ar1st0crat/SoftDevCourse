#ifndef TRIANGLE_H
#define TRIANGLE_H

#include "my_exceptions.h"
#include <QObject>
#include <vector>
#include <algorithm>
#include <cmath>

class Triangle : public QObject
{
    Q_OBJECT
public:
    explicit Triangle(QObject *parent = nullptr);
    Triangle(const double&, const double&, const double&);
    double area() const;
    void setSides(const double&, const double&, const double&);

    bool operator==(const Triangle& other) const;
private:
    double m_a;
    double m_b;
    double m_c;

    static void checkSidesIsCorrect(const double&, const double&, const double&);
    static void checkTriangleIsExisting(const double&, const double&, const double&);
};

#endif
