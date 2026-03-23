namespace APITemplate.Wrapper;

public class ApiResponse<T>
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }
    public List<string> Errors { get; set; } = new();

    public ApiResponse() { }
    public ApiResponse(T data, string message = null)
    {
        Success = true;
        Message = message;
        Data = data;
    }
}