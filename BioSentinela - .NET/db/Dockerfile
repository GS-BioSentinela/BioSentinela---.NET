FROM container-registry.oracle.com/database/express:21.3.0

# Define um diret�rio de trabalho
WORKDIR /opt/oracle/scripts/setup

# Usu�rio n�o root
RUN useradd -ms /bin/bash orcluser
USER orcluser

# Vari�vel de ambiente obrigat�ria
ENV ORACLE_CONN=Data Source=oracle.fiap.com.br:1521/orcl;User ID=xxxx;Password=xxxx;

EXPOSE 1521 5500
