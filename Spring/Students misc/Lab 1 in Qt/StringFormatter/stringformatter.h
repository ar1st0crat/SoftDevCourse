#ifndef STRINGFORMATTER_H
#define STRINGFORMATTER_H

#include <QObject>
#include <QString>
#include "my_exceptions.h"

class StringFormatter : public QObject
{
    Q_OBJECT
public:
    explicit StringFormatter(QObject *parent = nullptr);
    static QString webString(const QString&);
};

#endif
