namespace EmployeeManagement.API.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);  
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled Exception Occurred!"); 

                _logger.LogError("Request Path: {Path}", context.Request.Path);
                _logger.LogError("Request Method: {Method}", context.Request.Method);
                _logger.LogError("Exception Message: {Message}", ex.Message);
                _logger.LogError("Stack Trace: {StackTrace}", ex.StackTrace);

                context.Response.StatusCode = StatusCodes.Status500InternalServerError; 
                await context.Response.WriteAsync("An unexpected error occurred."); 
            }
        }
    }
}
