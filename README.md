A sample repo to get Bridge to Kubernetes working with a different provider to Azure.

To get started, run the following:

```
kubectl create namespace stonks
kubectl apply -f platform/nginx-ingress.yaml
kubectl apply -f platform/ingress.yaml
kubectl apply -f StonksApi/manifests/deployment.yaml
kubectl apply -f StonksApi/manifests/service.yaml
```

This will deploy the relevant things needed to the kubernetes cluster.

You should then be able to launch the app with Bridge to Kubernetes from the debug menu in vscode.
