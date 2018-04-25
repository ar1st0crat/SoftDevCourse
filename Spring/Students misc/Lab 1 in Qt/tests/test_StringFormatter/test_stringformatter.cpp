#include "test_stringformatter.h"

void Test_StringFormatter::webString()
{
    QString inputString(QStringLiteral(""));
    QString result = StringFormatter::webString(inputString);
    QVERIFY(result.isEmpty());

    inputString = QStringLiteral("test.addr.git");
    QString valueString(QStringLiteral("git://test.addr.git"));
    result = StringFormatter::webString(inputString);
    QCOMPARE(valueString, result);

    inputString = QStringLiteral("simple.adress");
    valueString = QStringLiteral("http://simple.adress");
    result = StringFormatter::webString(inputString);
    QCOMPARE(valueString, result);

    inputString = QStringLiteral("http://alreary.have");
    valueString = inputString;
    result = StringFormatter::webString(inputString);
    QCOMPARE (valueString, result);

    inputString = QString::null;
    QVERIFY_EXCEPTION_THROWN(StringFormatter::webString(inputString),
                             NullReferenceException);
}

QTEST_APPLESS_MAIN(Test_StringFormatter)

