using Singleton.RealWorldExample;

EventLogger eventLogger = EventLogger.GetInstance();

eventLogger.LogEvent("Iniciar app");
eventLogger.LogEvent("Ejecutar tarea 1");
eventLogger.LogEvent("Terminando tarea 1");


EventLogger eventLogger2 = EventLogger.GetInstance();

eventLogger2.LogEvent("Tarea del logger 2");
eventLogger2.LogEvent("Termina tarea de logger 2");
eventLogger2.LogEvent("Termina app");

eventLogger2.DisplayLogs();