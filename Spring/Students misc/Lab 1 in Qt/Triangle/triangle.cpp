#include "triangle.h"

Triangle::Triangle(QObject *parent) :
    Triangle(std::numeric_limits<double>::signaling_NaN(),
             std::numeric_limits<double>::signaling_NaN(),
             std::numeric_limits<double>::signaling_NaN())
{
}

Triangle::Triangle(const double& a, const double& b, const double& c) :
    QObject(nullptr)
{
    setSides(a, b, c); // исключение в конструкторе, очень блин красиво
}

double Triangle::area() const
{
    // heron formula
    if (std::isnan(m_a) || std::isnan(m_b) || std::isnan(m_c))
    {
        throw FormatException();
    }

    const double p = (m_a + m_b + m_c) / 2.0;
    return std::sqrt( p * (p - m_a) * (p - m_b) * (p - m_c));
}

void Triangle::setSides(const double& a, const double& b, const double& c)
{
    Triangle::checkSidesIsCorrect(a, b, c);
    Triangle::checkTriangleIsExisting(a, b, c);
    m_a = a;
    m_b = b;
    m_c = c;
}

void Triangle::checkSidesIsCorrect(const double& a, const double& b, const double& c)
{
    if (a < std::numeric_limits<double>::epsilon() ||
        b < std::numeric_limits<double>::epsilon() ||
        c < std::numeric_limits<double>::epsilon())
    {
        throw FormatException();
    }
}

void Triangle::checkTriangleIsExisting(const double& a, const double& b, const double& c)
{
    if ( a > (b+c) ||
         b > (a+c) ||
         c > (a+b))
    {
        throw ArgumentException();
    }
}


bool Triangle::operator==(const Triangle& other) const
{
    const double diffA = this->m_a - other.m_a;
    const double diffB = this->m_b - other.m_b;
    const double diffC = this->m_c - other.m_c;

    return  std::fabs(diffA) < std::numeric_limits<double>::epsilon() &&
            std::fabs(diffB) < std::numeric_limits<double>::epsilon() &&
            std::fabs(diffC) < std::numeric_limits<double>::epsilon();
}
