using DevExam;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services.AddPresentation();
}

var app = builder.Build();

{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
