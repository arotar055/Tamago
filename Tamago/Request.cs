using System;

class Request
{
    private string lastRequest;
    private string[] requests;
    public int RejectedRequests { get; set; }

    public Request()
    {
        requests = new string[] { "покормить", "погулять", "уложить спать", "полечить", "поиграть" };
        RejectedRequests = 0;
    }

    public string GenerateRequest()
    {
        Random random = new Random();
        string newRequest;
        do
        {
            newRequest = requests[random.Next(requests.Length)];
        } while (newRequest == lastRequest);

        lastRequest = newRequest;
        return newRequest;
    }

    public string CheckForNewRequest()
    {
        if (RejectedRequests < 3)
        {
            string request = GenerateRequest();
            Console.WriteLine($"Тамагочи просит: {request}");
            return request;
        }
        else
        {
            Console.WriteLine("Тамагочи заболел, нужно лечить!");
            return "полечить";
        }
    }

    public void RejectRequest()
    {
        RejectedRequests++;
        if (RejectedRequests >= 3)
        {
            Console.WriteLine("Тамагочи умирает!");
        }
    }
}
