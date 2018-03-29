#ifndef ARRAYPROCESSOR_H
#define ARRAYPROCESSOR_H

#include <QObject>
#include <QMap>
#include <tuple>
#include <algorithm>

class ArrayProcessor : public QObject
{
    Q_OBJECT
public:
    explicit ArrayProcessor(QObject *parent = nullptr);

    static std::vector<int> sortAndFilter(const int*, const std::size_t&);
};

#endif
