#include "arrayprocessor.h"

ArrayProcessor::ArrayProcessor(QObject *parent) : QObject(parent)
{

}

std::vector<int> ArrayProcessor::sortAndFilter(const int* arr, const std::size_t& lenght)
{
    QMap<int, int> negativeNumbers;
    std::size_t negNumbersCount = 0;
    for (std::size_t i = 0; i < lenght; ++i)
    {
        if (arr[i] < 0)
        {
            negativeNumbers[arr[i]]++;
            negNumbersCount++;
        }
    }
    const std::size_t& UniqueNegNumbersCount = negativeNumbers.keys().length();
    const std::size_t newLenght = lenght - negNumbersCount + UniqueNegNumbersCount;
    std::vector<int> newArr ( newLenght );
    int i = 0;
    for (const auto& negNumber: negativeNumbers.keys())
    {
        newArr[i++] = negNumber;
    }
    for (std::size_t j = 0; j < lenght; ++j)
    {
        if (arr[j] >= 0)
        {
            newArr[i++] = arr[j];
        }
    }
    std::sort(newArr.begin(), newArr.end());
    return newArr;
}
