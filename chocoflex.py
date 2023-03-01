import json
from aws_client import AWSClient

# Configurações do cliente AWS
access_key = 'AKIAVAQIVQT2QHVTA5HI'
secret_key = '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'
region = 'us-east-2'

# Inicializa o cliente AWS
aws_client = AWSClient(access_key, secret_key, region)

# Realiza a requisição ao serviço S3
lambda_service = aws_client.service('Lambda');
lambda_functions = lambda_service.get_all_functions();
with open('lambda_functions.json', 'w') as f:
    json.dump(lambda_functions, f)
print("Arquivo Criado com sucesso!")
# Realiza a requisição ao serviço EC2
# ec2_service = aws_client.service('EC2')
# ec2_instances = ec2_service.get_all_instances()
# with open('ec2_instances.json', 'w') as f:
#     json.dump(ec2_instances, f)