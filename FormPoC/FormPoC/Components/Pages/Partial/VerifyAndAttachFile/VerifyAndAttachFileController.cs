using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace FormPoC.Components.Pages.Partial.VerifyAndAttachFile
{
    public class VerifyAndAttachFileController(string verificationCheckBoxTitle, string submitButtonTitle, HttpClient _client, string _uploadUri, string _fileName)
    {
        public int Id { get; set; }

        //States
        public bool IsDisabled = true;
        private bool hasVerified = false;
        public bool HasVerified
        {
            get => hasVerified;
            set => hasVerified = value;
        }
        public bool HasSubmittedFile { get; private set; }

        //UI Properties
        public string VerificationCheckBoxTitle { get; private set; } = verificationCheckBoxTitle;
        public string SubmitButtonTitle { get; private set; } = submitButtonTitle;

        //File upload properties
        private readonly string uploadUri = _uploadUri;
        private readonly string fileName = _fileName;
        HttpClient httpClient = _client;
        public IBrowserFile SelectedFile { get; private set; }

        // Events
        public EventCallback<bool> FileSubmitted;
        public Func<Exception, Task> OnError { get; set; } = async (ex) => await Task.CompletedTask;
        //TODo Add validation for model, parentmodel and file

        //Methods
        public async Task SaveFileToDestinationAsync()
        {
            try
            {
                var content = new MultipartFormDataContent();
                var fileContent = new StreamContent(SelectedFile.OpenReadStream(104857600)); 
                fileContent.Headers.ContentType = new MediaTypeHeaderValue(SelectedFile.ContentType);
                content.Add(fileContent, fileName, SelectedFile.Name);

                var response = await httpClient.PostAsync(uploadUri, content);
                if (response.IsSuccessStatusCode)
                {
                    HasSubmittedFile = true;
                    await FileSubmitted.InvokeAsync(true);
                }
            }
            catch (Exception ex)
            {
                await OnError.Invoke(ex);
            }
        }
       public async Task HandleFileSelected(InputFileChangeEventArgs e)
        {
            SelectedFile = e.File;
        }

    }
}
