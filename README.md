# Hello, Lambda!

This is the code project for the [Hello, Lambda!](https://davidpallmann.hashnode.dev/hello-lambda) blog post. 

This episode: Lambda Functions. In this [Hello, Cloud](https://davidpallmann.hashnode.dev/series/hello-cloud) blog series, we're covering the basics of AWS cloud services for newcomers who are .NET developers. If you love C# but are new to AWS, or to this particular service, this should give you a jumpstart.

In this post we'll introduce AWS Lambda functions and write a "Hello, Cloud" in C#. We'll do this step-by-step, making no assumptions other than familiarity with C# and Visual Studio. If you've never worked with serverless, prepare to have your mind blown.

## Our Hello, Lambda Project

We'll use Visual Studio to create a simple "Hello, Lambda" function, deploy it to AWS, and test it. Our Lambda function will take a phone number input parameter (a string of digits) and return all the letter combinations.

With Lambda functions we have two ways of working available: we can upload a zipped deployment package, or we can upload a container. We will do a zipped deployment package here, and cover containers in a future post. At the time of this writing, the latest .NET version supported by AWS Lambda is .NET Core 3.1 for deployment projects and .NET 5 for containers.

See the blog post for the tutorial to create this project and run it on AWS.

