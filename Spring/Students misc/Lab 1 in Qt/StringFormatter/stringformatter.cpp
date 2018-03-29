#include "stringformatter.h"

StringFormatter::StringFormatter(QObject *parent) : QObject(parent)
{

}

QString StringFormatter::webString(const QString& s)
{
    if ( s.isNull())
    {
        throw NullReferenceException();
    }

    if (s.isEmpty())
    {
        return QString();
    }

    if (s.endsWith(QStringLiteral(".git")))
    {
        return QString(QStringLiteral("git://")).append(s);
    }
    else
    {
        if (!s.startsWith(QStringLiteral("http://")))
        {
            return QString(QStringLiteral("http://")).append(s);
        }
    }
    return s;
}
