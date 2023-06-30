# blazor-wasm-tester

## Deployment
- Set permissions for token used by actions (https://github.com/actions/checkout/issues/254#issuecomment-1118411040)
  - Go to project settings in the respective github repo
  - On the left menu, select Actions -> General
  - In Workflow permissions, select Read and write permissions
  - Re run failed jobs it should work
- Follow guide https://swimburger.net/blog/dotnet/how-to-deploy-aspnet-blazor-webassembly-to-github-pages
  - Publish command will create release folder in repo root
