#include "test_triangle.h"

void Test_Triangle::setSides()
{
    Triangle triangleConstr (3.0, 4.0, 5.0);

    QVERIFY_EXCEPTION_THROWN(Triangle(3.0, 4.0, 8.0), ArgumentException);

    QVERIFY_EXCEPTION_THROWN(Triangle(-3.0, 4.0, 5.0), FormatException);
    QVERIFY_EXCEPTION_THROWN(Triangle(3.0, -4.0, 5.0), FormatException);
    QVERIFY_EXCEPTION_THROWN(Triangle(3.0, 4.0, -5.0), FormatException);

    QVERIFY_EXCEPTION_THROWN(Triangle(0.0, 4.0, 5.0), FormatException);
    QVERIFY_EXCEPTION_THROWN(Triangle(3.0, 0.0, 5.0), FormatException);
    QVERIFY_EXCEPTION_THROWN(Triangle(3.0, 4.0, 0.0), FormatException);

    QVERIFY_EXCEPTION_THROWN(Triangle(0.0, 0.0, 0.0), FormatException);

    Triangle triangleMethod;
    triangleMethod.setSides(3.0, 4.0, 5.0);

    QVERIFY ( triangleConstr == triangleMethod);

    QVERIFY_EXCEPTION_THROWN(triangleMethod.setSides(3.0, 4.0, 8.0), ArgumentException);

    QVERIFY_EXCEPTION_THROWN(triangleMethod.setSides(-3.0, 4.0, 5.0), FormatException);
    QVERIFY_EXCEPTION_THROWN(triangleMethod.setSides(3.0, -4.0, 5.0), FormatException);
    QVERIFY_EXCEPTION_THROWN(triangleMethod.setSides(3.0, 4.0, -5.0), FormatException);

    QVERIFY_EXCEPTION_THROWN(triangleMethod.setSides(0.0, 4.0, 5.0), FormatException);
    QVERIFY_EXCEPTION_THROWN(triangleMethod.setSides(3.0, 0.0, 5.0), FormatException);
    QVERIFY_EXCEPTION_THROWN(triangleMethod.setSides(3.0, 4.0, 0.0), FormatException);

    QVERIFY_EXCEPTION_THROWN(triangleMethod.setSides(0.0, 0.0, 0.0), FormatException);
}

void Test_Triangle::area()
{
    Triangle triangle;
    QVERIFY_EXCEPTION_THROWN(triangle.area(), FormatException);
    triangle.setSides(3.0, 4.0, 5.0);
    const double expectedResult = 6.0;
    const auto differents = triangle.area() - expectedResult;
    QVERIFY ( std::fabs(differents) <  std::numeric_limits<decltype(differents)>::epsilon());
}
QTEST_APPLESS_MAIN(Test_Triangle)
