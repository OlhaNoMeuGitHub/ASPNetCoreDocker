import requests
from requests_aws4auth import AWS4Auth
# from s3_service import LambdaService
from ec2_service import EC2Service
from lambda_service import LambdaService

class AWSClient:
    def __init__(self, access_key, secret_key, region):
        self.access_key = access_key
        self.secret_key = secret_key
        self.region = region
        # self.session = requests.Session()
        # self.session.auth = AWS4Auth(access_key, secret_key, region, 'execute-api')
        self.services = {
            'Lambda': LambdaService(region = self.region, access_key = self.access_key, secret_key = self.secret_key),
            'EC2': EC2Service(region = self.region, access_key = self.access_key, secret_key = self.secret_key)
        }

    def service(self, service_name):
        service = self.services.get(service_name)
        if not service:
            raise ValueError(f"Service '{service_name}' not supported.")
        return service
    