@echo off
cls
echo        =========================================
echo        I         Preparing Auto Build          I
echo        =========================================
timeout /t 4
cls
echo        =========================================
echo        I             xCopy Results             I
echo        =========================================
echo.
xcopy "Release" "IQPrinterKicker" /h /i /c /k /e /r /y
echo.
timeout /t 2