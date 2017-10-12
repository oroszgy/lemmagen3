FROM mono:5.2

WORKDIR /lemmagen
COPY ./ /lemmagen
RUN xbuild ./LemmaSharpPrebuiltFull.sln

