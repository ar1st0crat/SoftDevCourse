#include "test_arrayprocessor.h"

void Test_ArrayProcessor::sortAndFilter()
{
    const std::vector<int> testValues {
        -3, 15, 0, 1, -3, -21, 4, 8, -7, 5, 4, 11, -7
    };

    const std::vector<int> testValuesCopy { testValues };

    const std::vector<int> resultValues {
        -21, -7, -3, 0, 1, 4, 4, 5, 8, 11, 15
    };
    auto classResult = ArrayProcessor::sortAndFilter(testValues.data(),
                                                     testValues.size());
    QCOMPARE(resultValues, classResult);

    QCOMPARE(testValues, testValuesCopy);
}

QTEST_APPLESS_MAIN(Test_ArrayProcessor)
