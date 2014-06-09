/* 
**  Usage:
**      time_string(format [,sep])
**
**  Arguments:
**      format      12 or 24 for 12 or 24 hour clock, real
**      sep         string to use as seperator, ":" is default (optional)
**
**  Returns:
**      the system time as a string in 12 or 24 hour "HH:MM:SS" format
**
**  GMLscripts.com
*/
{
    var format,sep,date,hours,mins,secs,str_hr,str_mn,str_sc,str_time;
    format = argument0;
    sep = argument1;
    if (is_real(sep)) sep = ":";
    date = date_current_datetime();
    hours = date_get_hour(date);
    if ((format == 12) && (hours > 12)) hours -= 12;
    if (hours < 10) str_hr = "0" + string(hours); 
    else str_hr = string(hours);
    mins = date_get_minute(date);
    if (mins < 10) str_mn = "0" + string(mins); 
    else str_mn = string(mins);
    secs = date_get_second(date);
    if (secs < 10) str_sc = "0" + string(secs); 
    else str_sc = string(secs);
    str_time = str_hr + sep + str_mn + sep + str_sc;
    return (str_time);
}
