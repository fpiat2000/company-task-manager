using PolcarZadanie.Models;
using RestSharp;

namespace ZadanieTesty
{
    public class TaskAppTests
    {
        // TODO this URL was taken directly from launchSettings.json
        private string ApiUrl = "https://localhost:7154";
        private string ResourceUrl = "/api/tasks";
        private RestClient TestClient;

        [SetUp]
        public void Setup()
        {
            TestClient = new RestClient(ApiUrl);
        }

        [TearDown]
        public void TearDown()
        {
            TestClient.Dispose();
        }

        [Test]
        public async Task TestTaskCreation()
        {
            // Simple test case: Create new task, then make sure it is retrieved
            var task = new WorkTask
            {
                Header = "TestHeader1",
                Priority = 11,
                Description = "TestDescription1",
                AssignedEmployee = null,
                CreationDate = DateTime.Now
            };
            var createRequest = new RestRequest(ResourceUrl);
            createRequest.AddBody(task, ContentType.Json);
            var createResponse = await TestClient.ExecutePostAsync(createRequest);
            Assert.That(createResponse.IsSuccessful, Is.True);

            var getTasks = await TestClient.ExecuteGetAsync<List<WorkTask>>(new RestRequest(ResourceUrl));
            Assert.That(getTasks.IsSuccessful, Is.True);
            var taskList = getTasks.Data;
            Assert.That(taskList, Is.Not.Null);
            Assert.That(taskList.Exists(t => t.CreationDate.GetValueOrDefault() >= task.CreationDate.Value), Is.True);
        }

        [Test]
        public async Task TestValidation()
        {
            var task = new WorkTask
            {
                Header = "T",
                Priority = 999199,
                Description = "T",
                AssignedEmployee = null,
                CreationDate = DateTime.Now
            };
            var createRequest = new RestRequest(ResourceUrl);
            createRequest.AddBody(task, ContentType.Json);
            var createResponse = await TestClient.ExecutePostAsync(createRequest);
            Assert.That(createResponse.IsSuccessful, Is.False);

            var getTasks = await TestClient.ExecuteGetAsync<List<WorkTask>>(new RestRequest(ResourceUrl));
            Assert.That(getTasks.IsSuccessful, Is.True);
            var taskList = getTasks.Data;
            Assert.That(taskList, Is.Not.Null);
            Assert.That(taskList.Exists(t => t.CreationDate == task.CreationDate), Is.False);
        }

        [Test, Combinatorial]
        public async Task TestTaskDeletion([Values(1200,2400,4800,9600)] long taskId)
        {
            var deleteRequest = new RestRequest($"{ResourceUrl}/{taskId}");
            var deleteResponse = await TestClient.ExecuteDeleteAsync(deleteRequest);
            Assert.That(deleteResponse.IsSuccessful, Is.False);
        }
    }
}