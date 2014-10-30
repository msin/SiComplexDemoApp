using System;

namespace IocApp.CIL
{
    public static class SafeCode
    {
        public static ILogger logger;

        /// <summary>
        /// Выполнение метода, возвращающего значение через обёртку try-catch
        /// Пример: int val = SafeCode.Execute<int>(GetValue(int par1), "Ошибка при вызове GetValue(" + par1 + ")\n");
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="operation"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static T Execute<T>(Func<T> operation, string message)
        {
            try
            {
                return operation();
            }
            catch (Exception ex)
            {
                logger.Error(message, ex);
                throw ex;
            }

            return default(T);
        }

        /// <summary>
        /// Выполнение метода через обёртку try-catch
        /// Пример: SafeCode.Execute(() => RunMethod(int par1), "Ошибка при вызове RunMethod(" + par1 + ")\n");
        /// </summary>
        /// <param name="action"></param>
        /// <param name="message"></param>
        public static void Execute(Action action, string message)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                logger.Error(message, ex);
                throw ex;
            }
        }

        //public static void Execute<T>(Action<T> operation, T item)
    }
}
